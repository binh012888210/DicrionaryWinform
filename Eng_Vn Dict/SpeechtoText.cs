using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using GoogleTranslator;

namespace Eng_Vn_Dict
{
    public partial class SpeechtoText : Form
    {
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        public SpeechtoText()
        {
            InitializeComponent();
        }

        private void Translate_Click(object sender, EventArgs e)
        {
            Translator trans = new Translator();
            Output_Speech.Text = string.Empty;
            Output_Speech.Update();
            try
            {
                Cursor = Cursors.WaitCursor;
                Output_Speech.Text = trans.Translate(Input_Speech.Text.ToString(), inputLang.SelectedItem.ToString(), outputLang.SelectedItem.ToString());
                if (trans.Error != null)
                {
                    MessageBox.Show(trans.Error.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void SpeechtoText_Load(object sender, EventArgs e)
        {
            Translator Trans = new Translator();
            List<string> T;
            Trans.Languages(out T);
            inputLang.Items.AddRange(T.ToArray());
            outputLang.Items.AddRange(T.ToArray());
            inputLang.SelectedItem = "English";
            outputLang.SelectedItem = "Vietnamese";
        }

        private void record_Click(object sender, EventArgs e)
        {
            stpRec.Enabled = true;
            record.BackColor = Color.Silver;
            stpRec.BackColor = Color.WhiteSmoke;
            try
            {
                recognizer.SetInputToDefaultAudioDevice();
                recognizer.LoadGrammar(new DictationGrammar());
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
                recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_recognized);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void recognizer_recognized(object sender, SpeechRecognizedEventArgs e)
        {
            string input = e.Result.Text.ToString();
            Input_Speech.Text = input;
        }

        private void stpRec_Click(object sender, EventArgs e)
        {
            record.BackColor = Color.WhiteSmoke;
            stpRec.BackColor = Color.Silver;
            recognizer.RecognizeAsyncStop();

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Input_Speech.Clear();
        }

        private void Input_Speech_TextChanged(object sender, EventArgs e)
        {
            Input_Speech.Select(Input_Speech.TextLength, 0);
            if (Input_Speech.Text.Count() == 0) return;
            if (Input_Speech.Text[Input_Speech.TextLength - 1] == '\n'
                || Input_Speech.Text[Input_Speech.TextLength - 1] == '\t')

                Input_Speech.Text = Input_Speech.Text.Remove(Input_Speech.TextLength - 1);
        }
    }
}
