using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GoogleTranslator
{
    class Translator
    {
        private static Dictionary<string, string> languageModeMap;//lưu dữ liệu dưới dạng (key,value) collection

        private static void EnsureInitialized()
        {
            if (Translator.languageModeMap == null)
            {
                Translator.languageModeMap = new Dictionary<string, string>();
                Translator.languageModeMap.Add("Afrikaans", "af");
                Translator.languageModeMap.Add("Albanian", "sq");
                Translator.languageModeMap.Add("Arabic", "ar");
                Translator.languageModeMap.Add("Armenian", "hy");
                Translator.languageModeMap.Add("Azerbaijani", "az");
                Translator.languageModeMap.Add("Basque", "eu");
                Translator.languageModeMap.Add("Belarusian", "be");
                Translator.languageModeMap.Add("Bengali", "bn");
                Translator.languageModeMap.Add("Bulgarian", "bg");
                Translator.languageModeMap.Add("Catalan", "ca");
                Translator.languageModeMap.Add("Chinese", "zh-CN");
                Translator.languageModeMap.Add("Croatian", "hr");
                Translator.languageModeMap.Add("Czech", "cs");
                Translator.languageModeMap.Add("Danish", "da");
                Translator.languageModeMap.Add("Dutch", "nl");
                Translator.languageModeMap.Add("English", "en");
                Translator.languageModeMap.Add("Esperanto", "eo");
                Translator.languageModeMap.Add("Estonian", "et");
                Translator.languageModeMap.Add("Filipino", "tl");
                Translator.languageModeMap.Add("Finnish", "fi");
                Translator.languageModeMap.Add("French", "fr");
                Translator.languageModeMap.Add("Galician", "gl");
                Translator.languageModeMap.Add("German", "de");
                Translator.languageModeMap.Add("Georgian", "ka");
                Translator.languageModeMap.Add("Greek", "el");
                Translator.languageModeMap.Add("Haitian Creole", "ht");
                Translator.languageModeMap.Add("Hebrew", "iw");
                Translator.languageModeMap.Add("Hindi", "hi");
                Translator.languageModeMap.Add("Hungarian", "hu");
                Translator.languageModeMap.Add("Icelandic", "is");
                Translator.languageModeMap.Add("Indonesian", "id");
                Translator.languageModeMap.Add("Irish", "ga");
                Translator.languageModeMap.Add("Italian", "it");
                Translator.languageModeMap.Add("Japanese", "ja");
                Translator.languageModeMap.Add("Korean", "ko");
                Translator.languageModeMap.Add("Lao", "lo");
                Translator.languageModeMap.Add("Latin", "la");
                Translator.languageModeMap.Add("Latvian", "lv");
                Translator.languageModeMap.Add("Lithuanian", "lt");
                Translator.languageModeMap.Add("Macedonian", "mk");
                Translator.languageModeMap.Add("Malay", "ms");
                Translator.languageModeMap.Add("Maltese", "mt");
                Translator.languageModeMap.Add("Norwegian", "no");
                Translator.languageModeMap.Add("Persian", "fa");
                Translator.languageModeMap.Add("Polish", "pl");
                Translator.languageModeMap.Add("Portuguese", "pt");
                Translator.languageModeMap.Add("Romanian", "ro");
                Translator.languageModeMap.Add("Russian", "ru");
                Translator.languageModeMap.Add("Serbian", "sr");
                Translator.languageModeMap.Add("Slovak", "sk");
                Translator.languageModeMap.Add("Slovenian", "sl");
                Translator.languageModeMap.Add("Spanish", "es");
                Translator.languageModeMap.Add("Swahili", "sw");
                Translator.languageModeMap.Add("Swedish", "sv");
                Translator.languageModeMap.Add("Tamil", "ta");
                Translator.languageModeMap.Add("Telugu", "te");
                Translator.languageModeMap.Add("Thai", "th");
                Translator.languageModeMap.Add("Turkish", "tr");
                Translator.languageModeMap.Add("Ukrainian", "uk");
                Translator.languageModeMap.Add("Urdu", "ur");
                Translator.languageModeMap.Add("Vietnamese", "vi");
                Translator.languageModeMap.Add("Welsh", "cy");
                Translator.languageModeMap.Add("Yiddish", "yi");
            }
        }//nạp dữ liệu vào languageModeMap dưới dạng dictionary

        public List<string> Languages(out List<string> T)//hàm liệt kê các tên ngôn ngữ trong Dictionary
        {
            Translator.EnsureInitialized();
            T = Translator.languageModeMap.Keys.ToList();
            return T;
        }

        public Exception Error
        {
            get;
            private set;
        }

        private static string LanguageEnumToIdentifier(string language)//lấy value tương ứng với key
        {
            string mode = string.Empty;
            Translator.EnsureInitialized();
            Translator.languageModeMap.TryGetValue(language, out mode);//(key,value)
            return mode;
        }

        public string Translate(string sourceText, string sourceLanguage, string targetLanguage)
        {
            string translation = string.Empty;
            try
            {
                // Download translation
                string url = string.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                    Translator.LanguageEnumToIdentifier(sourceLanguage), Translator.LanguageEnumToIdentifier(targetLanguage), HttpUtility.UrlEncode(sourceText));
                string outputFile = Path.GetTempFileName();
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile(url, outputFile);
                }
                if (File.Exists(outputFile))
                {
                    string text = File.ReadAllText(outputFile);
                    string[] entries = text.Split('"');
                    translation = entries[1];
                }
            }
            catch (Exception ex)
            {
                this.Error = ex;
            }
            return translation;
        }
    }
}
