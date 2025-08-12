public class GroupAnagrams {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var grupos = new Dictionary<string, List<string>>();

        foreach (string word in strs)
        {
            int[] freq = new int[26];

            // Bucle interno: contar letras
            foreach (char c in word)
            {
                int idx = c - 'a';
                freq[idx]++;
            }

            // Crear clave después de contar toda la palabra
            string key = string.Join("#", freq);

            // Añadir al diccionario
            if (!grupos.ContainsKey(key))
            {
                grupos[key] = new List<string>();
            }
            grupos[key].Add(word);
        }

        // Convertir valores del diccionario a List<List<string>>
        return new List<List<string>>(grupos.Values);
    }

}
