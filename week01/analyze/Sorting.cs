public static class Sorting {
    public static void Run() {
        var numbers = new[] { 3, 2, 1, 6, 4, 9, 8 };
        SortArray(numbers);
        Console.Out.WriteLine("int[]{{{0}}}", string.Join(", ", numbers)); //int[]{1, 2, 3, 4, 6, 8, 9}
    }

    // O (n^2)
    private static void SortArray(int[] data) {
        // Start at the end of the array.
        for (var sortPos = data.Length - 1; sortPos >= 0; sortPos--) {
            for (var swapPos = 0; swapPos < sortPos; ++swapPos) { // For each item start at the beginning and see if it's smaller than the item at the end of the array
                if (data[swapPos] > data[swapPos + 1]) {
                    (data[swapPos + 1], data[swapPos]) = (data[swapPos], data[swapPos + 1]);
                }
            }
        }
    }
}