import java.util.Scanner;

class SaraRec{
  public static void main(String[] args) {
    double gros_salary, daysWorked, netSalary, taxDeducted;
    double bonus;

    System.out.println("---------------SARAH'S WORK CHART-------------\n\n\n");
    Scanner outlook = new Scanner(System.in);
    System.out.println("Number of days worked: ");
    daysWorked = outlook.nextInt();
    System.out.println("\n\nNUMBER OF DAYS WORKED = " + daysWorked);

    gros_salary = 200000;
    System.out.println("SALARY = " + gros_salary);


    if(daysWorked == 30){
      bonus = 100000;
      taxDeducted = 0.1 * bonus;
      System.out.println("BONUS = " + bonus);
      System.out.println("TAX DEDUCTED = " + taxDeducted);
      netSalary = gros_salary + (bonus - taxDeducted);
      System.out.println("NET SALARY = " + netSalary);
    }
    else{
      bonus = 0;
      taxDeducted = 0;
      System.out.println("BONUS = " + bonus);
      System.out.println("TAX DEDUCTED = " + taxDeducted);
      netSalary = gros_salary + (bonus - taxDeducted);
      System.out.println("NET SALARY = " + netSalary);
    }




    }
  }
