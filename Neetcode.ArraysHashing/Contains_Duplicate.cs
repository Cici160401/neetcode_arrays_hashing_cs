using System.Collections.Generic;

namespace Neetcode.ArraysHashing;


public static class ContainsDuplicateSolution
{
    /// <returns>
    /// True si hay al menos un número repetido; de lo contrario, false.
    /// Complejidad: O(n) tiempo, O(n) espacio.
    /// </returns>
    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seen = new();
        foreach (int n in nums)
        {
            if (!seen.Add(n))   // Add devuelve false si ya existía
                return true;
        }
        return false;
    }
}