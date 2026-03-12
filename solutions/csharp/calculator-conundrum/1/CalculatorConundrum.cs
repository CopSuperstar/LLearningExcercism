public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        string str = "+*/";
if (operation ==null){
            throw new ArgumentNullException();
            }
           if (operation == ""){
            throw new ArgumentException();
        }
        
        if (!str.Contains(operation)){
            throw new ArgumentOutOfRangeException();
            }
        
        if (operation =="+"){
            return   $"{operand1} {operation} {operand2} = {SimpleOperation.Addition(operand1, operand2)}" ;
        }
        if (operation =="*"){
            return   $"{operand1} {operation} {operand2} = {SimpleOperation.Multiplication(operand1, operand2)}" ;
        }
        if (operation =="/"){
           
                if (operand2 == 0)
                {
                    return "Division by zero is not allowed.";
                }
         
            return   $"{operand1} {operation} {operand2} = {SimpleOperation.Division(operand1, operand2)}" ;
        }

        return "";
    }
}

