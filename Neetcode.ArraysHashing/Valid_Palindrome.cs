 public class IsPalindromeSolution {
 
 // ESTE MÉTODO ES INEFICIENTE PORQUE CREA NUEVAS CADENAS EN CADA CONCATENACIÓN, LO QUE TIENE UNA COMPLEJIDAD DE O(n^2) EN EL PEOR CASO.
 // UNA MEJOR SOLUCIÓN USARÍA UN STRINGBUILDER O DOS PUNTEROS PARA EVITAR LA CREACIÓN DE NUEVAS CADENAS.
 
    public bool IsPalindrome(string s) {
        string newStr = "";
        foreach (char c in s) {
            if (char.IsLetterOrDigit(c)) {
                newStr += char.ToLower(c);
            }
        }
        return newStr == new string(newStr.Reverse().ToArray());
    }
}