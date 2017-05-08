namespace StreamWriterStreamReader.Application.Escrita
{
    public static class StringExtensions
    {

        public static string Pluralize(this string texto)
        {
            if(texto.EndsWith("s"))
            {
                return texto;
            }else
            {
                return texto + "s";
            }

        }
    }
}
