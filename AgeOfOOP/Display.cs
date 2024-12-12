﻿namespace AgeOfOOP;

public static class Display
{
    
    public static void TitleScreen()
    {
        Console.Clear();
        Console.WriteLine("   \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588    \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2584     \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588       \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2584     \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588       \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2584   \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2584     \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2584 \n  \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588      \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588      \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588 \n  \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2580    \u2588\u2588\u2588    \u2588\u2580       \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2580       \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588 \n  \u2588\u2588\u2588    \u2588\u2588\u2588  \u2584\u2588\u2588\u2588         \u2584\u2588\u2588\u2588\u2584\u2584\u2584          \u2588\u2588\u2588    \u2588\u2588\u2588  \u2584\u2588\u2588\u2588\u2584\u2584\u2584          \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588 \n\u2580\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588 \u2580\u2580\u2588\u2588\u2588 \u2588\u2588\u2588\u2588\u2584  \u2580\u2580\u2588\u2588\u2588\u2580\u2580\u2580          \u2588\u2588\u2588    \u2588\u2588\u2588 \u2580\u2580\u2588\u2588\u2588\u2580\u2580\u2580          \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588    \u2588\u2588\u2588 \u2580\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2580  \n  \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2584       \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588             \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588        \n  \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588      \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588             \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588        \n  \u2588\u2588\u2588    \u2588\u2580    \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2580    \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588       \u2580\u2588\u2588\u2588\u2588\u2588\u2588\u2580    \u2588\u2588\u2588              \u2580\u2588\u2588\u2588\u2588\u2588\u2588\u2580   \u2580\u2588\u2588\u2588\u2588\u2588\u2588\u2580   \u2584\u2588\u2588\u2588\u2588\u2580 \n");
        Console.WriteLine("DISCLAIMER: This game can't even come close to matching the scope of the original AOE series (so don't expect much).");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("[1] Start\t[0] Exit");
    }

    public static void ChooseCivilization()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------------------\n" +
                          "Choose your Civilization:\n" +
                          "---------------------------------------------------\n" +
                          "[1] Greeks\t[2] Minoans\t[3] Phoenicians\n" +
                          "[4] Assyrians\t[5] Egyptians\t[6] Sumerians\n" +
                          "[7] Babylonians\t[8] Hittites\t[9] Persians\n" +
                          "[Q] Choson\t[W] Shang\t[E] Yamato\n");
        
    }
}