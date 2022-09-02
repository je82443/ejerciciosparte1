namespace ejercicios
{

}
    public class program
{
    public static void Main()
    {
        int num1;
        int num2;
        int num3;
        int num4;
        int suma;
        int media;
        int product; 
        Console.WriteLine("por favor ingrese el numero que se va a realizar el proceso");
        num1=int.Parse(Console.ReadLine()); 
        Console.WriteLine("por favor digiote el segundo numero");
        num2=int.Parse(Console.ReadLine());
        Console.WriteLine("por favor digite el tercer numero"); 
        num3=int.Parse(Console.ReadLine());
        Console.WriteLine("Por favor digite el curto numero"); 
        num4=int.Parse(Console.ReadLine()); 
        product = num1 *num2 * num3 * num4;
        suma= num1 + num2   + num3 + num4;
        media = suma / 4;
        Console.WriteLine($"el resultado de la suma es: {suma} el resultado de la media es {media} el resultado del producto es {product} "); 







    }

}