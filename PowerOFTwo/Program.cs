namespace Basic_Core_Program
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to basic problems ");
            Console.WriteLine("1 for Flip Coin");
            Console.WriteLine("2 for Leap Year");
            Console.WriteLine("3 for Power of Two");
            Console.WriteLine("4 for Harmonic Number");
            Console.WriteLine("5 for Factors Number");
            Console.WriteLine("6 for Compute The Number");
            Console.WriteLine("7 for Swap Two Number");
            Console.WriteLine("8 for Number is Even or Odd");
            Console.WriteLine("9 for Check for Vowel and Consonant");
            Console.WriteLine("10 for Cheak Witch Number is Greater ");

            int Option=Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    Flip_Coin result = new Flip_Coin();
                    result.CoinFlip();
                    break;
                case 2:
                    Leap_Year Leap = new Leap_Year();
                    Leap.Year_Leap();
                    break;
                case 3:
                    PowerOfTwo Power=new PowerOfTwo();
                    Power.Power();
                    break;
                case 4:
                    HarmonicNumber Har = new HarmonicNumber();
                    Har.Harmonic();
                    break;
                case 5:
                    Factors Fact = new Factors();
                    Fact.Factor();
                    break;
                case 6:
                    Compute Com = new Compute();
                    Com.Que_Rem();
                    break;
                case 7:
                    Swap SwapNumber = new Swap();
                    SwapNumber.SwapNumber();
                    break;
                case 8:
                    NumberEvenOrOdd EvenOdd = new NumberEvenOrOdd();
                    EvenOdd.EvenOdd();
                    break;
                case 9:
                    Alp_Vowel_Consonant VowelCon = new Alp_Vowel_Consonant();
                    VowelCon.Vowel_Consonant();
                    break;
                case 10:
                    LargestThreeNumber LargestThree = new LargestThreeNumber();
                    LargestThree.ThreeNumber();
                    break;

            }
}
    }
}