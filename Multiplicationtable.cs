public class MultiplicationTable {

    public static void main(String[] args) {
        
      Console.WriteLine("Multiplication table of 1 - 12. \n");
      
for (int i=1;i<=12;i++){
        Console.WriteLine("Table"+i);
for (int j=1;j<=12;j++){
     int z = i*j;
     Console.WriteLine(i+"*"+j+"="+z);
}
    Console.WriteLine("End of the table: "+i);
    Console.WriteLine("----------.\n");
}
        
        
    }
    
}