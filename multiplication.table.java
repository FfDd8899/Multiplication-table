package multiplication.table;

public class MultiplicationTable {

    public static void main(String[] args) {
        
      System.out.println("Multiplication table of 1 - 12. \n");
      
for (int i=1;i<=12;i++){
        System.out.println("Table"+i);
for (int j=1;j<=12;j++){
     int z = i*j;
     System.out.println(i+"*"+j+"="+z);
}
    System.out.println("End of the table: "+i);
    System.out.println("----------.\n");
}
        
        
    }
    
}
