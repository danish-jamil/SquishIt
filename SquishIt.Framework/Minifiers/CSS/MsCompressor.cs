using Microsoft.Ajax.Utilities;

namespace SquishIt.Framework.Minifiers.CSS
{
    public class MsCompressor: ICSSMinifier
    {
        public CssSettings Settings { get; set; }

        public MsCompressor()
        {
        }

        public MsCompressor(CssSettings settings)
        {
            Settings = settings;
        }

        public string Minify(string content)
        {
            var minifier = new Minifier();
            var stylesheet = string.Empty;

            if (Settings != null)
            {
                stylesheet = minifier.MinifyStyleSheet(content, Settings);
            }
            else 
            {
                stylesheet = minifier.MinifyStyleSheet(content);
            }

            return stylesheet;
        }
    }
}