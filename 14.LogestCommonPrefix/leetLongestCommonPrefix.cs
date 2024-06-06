namespace _14.LogestCommonPrefix
{
    public static class leetLongestCommonPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            // Inizializza una stringa vuota per memorizzare il prefisso comune
            string res = "";

            // Ciclo per ogni carattere nella prima stringa del'array
            for (int i = 0; i < strs[0].Count(); i++)
            {
                // Controlla ogni stringa nell'array
                foreach (string str in strs)
                {
                    // Se l'indice corrente è uguale alla lunghezza della stringa
                    // oppure il carattere corrente non corrisponde al carattere
                    // nella stessa posizione della prima stringa
                    if (i == str.Length || str[i] != strs[0][i])
                    {
                        // Ritorna il prefisso comune trovato fino a questo punto
                        return res;
                    }
                }
                // Aggiungi il carattere corrente al prefisso comune
                res += strs[0][i];
            }

            // Ritorna il prefisso comune (se il ciclo si completa senza interruzioni)
            return res;
        }

    }
}
