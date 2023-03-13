class Program{
    static void Main (string[] args){

        Console.WriteLine ("Plz input first paper center X : ");
        int x1 = int.Parse(Console.ReadLine());
        Console.WriteLine ("Plz input first paper center Y : ");
        int y1 = int.Parse(Console.ReadLine());
        Console.WriteLine ("Plz input first paper wide : ");
        int wide1 = int.Parse(Console.ReadLine());
        Console.WriteLine ("Plz input first paper hieght : ");
        int height1 = int.Parse(Console.ReadLine());

        Console.WriteLine ("Plz input second paper center X : ");
        int x2 = int.Parse(Console.ReadLine());
        Console.WriteLine ("Plz input second paper center Y : ");
        int y2 = int.Parse(Console.ReadLine());
        Console.WriteLine ("Plz input second paper wide : ");
        int wide2 = int.Parse(Console.ReadLine());
        Console.WriteLine ("Plz input second paper hieght : ");
        int height2 = int.Parse(Console.ReadLine());

        int left = Math.Max(x1 - wide1, x2 - wide2);
        int right = Math.Min(x1 + wide1, x2 + wide2);
        int top = Math.Max(y1 - height1, y2 - height2);
        int bottom = Math.Min(y1 + height1, y2 + height2);

        int overlap = Math.Max(0, right - left) * Math.Max(0, bottom - top);

        if (overlap > 8){
            Console.WriteLine("Too Much Overlapping");
        }
        else if (overlap > 0){
            Console.WriteLine("Not Much Overlapping");
        }
        else{
            Console.WriteLine("No Overlapping");
        }

    }
}