using UserRegistration;
class program
{
    static void Main(string[] args)
    {
        Pattern pattern = new Pattern();
        //Console.WriteLine(pattern.validateFirstName("Raj"));
        //Console.WriteLine(pattern.validateLastName("Roy"));
        //Console.WriteLine(pattern.valiadtaeEmail("alam41976@gmail.com"));     
        //Console.WriteLine(pattern.validateMobileNumber("91 79719623"));
        //Console.WriteLine(pattern.validatePaswordRule1("a@bcd13"));
        //Console.WriteLine(pattern.validatePaswordRule2("a@123af"));
        // Console.WriteLine(pattern.validatePaswordRule3("5@bcde"));
        Console.WriteLine(pattern.validatePaswordRule4("a@2459"));
    }

}