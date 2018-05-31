import java.util.Scanner;
public class profile{
    public static float age = 19f;
    public static boolean New = true;
	public static int Num = 1;	
	public static String[] Fav;

  public static void main(String args[]){
	  
    System.out.println("Are you new here?");
    System.out.println("That is " + New + " hmm? Let me redirect you.");
	
	Fav = new String[4];
	
	Fav[0] = "Unity";
	Fav[1] = "Spaghetti";
	Fav[2] = "Nintendo";
	Fav[3] = "#00cc99";

    if(New){
      System.out.println("What is your name?");
      Scanner scanner = new Scanner(System.in);
      String name = scanner.nextLine();
      System.out.println("So your name is " + name + " huh? Neat!");
      System.out.println("I'm Sjors, Nice to meet you " + name + "!\nI program some fancy stuff!");
      System.out.println("I'm " + age + " years old.");
      System.out.println("My favorite color is " + Fav[3] + ".\nAnd I love " + Fav[1] + "!");
	  New = false;
      Other();

    }else if(!New){
      System.out.println("Good to see you again!");
      Quit(Num);

    }else{
      System.out.println("How did you get here.");
      Quit(Num);
    }
  }

  public static void Other(){
    System.out.println("I enjoy playing " + Fav[2] +" games,\nAnd always up to meet new people.");
    System.out.println("Jazz is pretty neat.\nFavorite engine: " + Fav[0] + ".");
    System.out.println("And not looking for a relationship,\nThere is a beautiful person who I love more than anyone.");
    Quit(Num);
    System.out.println("~This program should never reach this place~");
  }

  public static void Quit(int num){
    System.exit(num);
  }
}
