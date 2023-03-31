//using System;
//using System.Threading.Tasks;

//namespace EventOrganizer
//{
//    //The chief guest needs to be picked up from the airport.
//    //The stage has to be decorated.
//    //The catering team needs to start preparing food
//    //The transport team needs to drop the food raw materials to the venue before the cooking needs to start.
//    //The chief guest's speech needs to be reviewed by the PA
//    //The venue needs to be checked for security features like bomb threat, etc
//    //Prize distribution is set to happen at the end of the event so all the prizes that need to be presented should be brought to the venue.
//    //The chief guest needs to give the speech.
//    //Prizes need to be distributed.
//    //Food has to be provided to all participants.

//    class Program
//    {
//        static async Task Main(string[] args)
//        {
//            Console.WriteLine("Event organization commencement\n");
//            await Task.WhenAll(DecorateStage(), PrepareFood(), CheckSecurity(), BringPrizes());
//            await PickUpChiefGuest();

//            Console.WriteLine("\nMain Event");
//            await GiveSpeech();
//            await Task.Delay(2000);
//            await DistributePrizes();
//            await Task.Delay(2000);
//            await ServeFood();

//            Console.WriteLine("Event end\n");
//        }

//        static async Task PickUpChiefGuest()
//        {
//            Console.WriteLine("Chief guest pickup initiated");
//            await Task.Delay(2000); 
//            Console.WriteLine("Chief guest pickup completed");
//            await ReviewSpeech();
//        }

//        static async Task DecorateStage()
//        {
//            Console.WriteLine("Stage Decoration initiated");
//            await Task.Delay(3000); 
//            Console.WriteLine("Stage Decoration completed");
//        }

//        static async Task PrepareFood()
//        {
//            await DropRawMaterials();
//            Console.WriteLine("Food Preparation initiated");
//            await Task.Delay(10000); 
//            Console.WriteLine("Food Preparation completed");
//        }

//        static async Task DropRawMaterials()
//        {
//            Console.WriteLine("Raw material drop initiated");
//            await Task.Delay(2000); 
//            Console.WriteLine("Raw material drop completed");
//        }

//        static async Task ReviewSpeech()
//        {
//            Console.WriteLine("Speech Review initiated");
//            await Task.Delay(3000); 
//            Console.WriteLine("Speech Review completed");
//        }

//        static async Task CheckSecurity()
//        {
//            Console.WriteLine("Security check initiated");
//            await Task.Delay(4000); 
//            Console.WriteLine("Security check completed");
//        }

//        static async Task BringPrizes()
//        {
//            Console.WriteLine("Prizes arrival to the venue initiated");
//            await Task.Delay(5000); 
//            Console.WriteLine("Prizes arrival to the venue completed");
//        }

//        static async Task GiveSpeech()
//        {
//            Console.WriteLine("Speech initiated");
//            await Task.Delay(7000); 
//            Console.WriteLine("Speech completed");
//        }

//        static async Task DistributePrizes()
//        {
//            Console.WriteLine("Prize distribution initiated");
//            await Task.Delay(5000); 
//            Console.WriteLine("Prize distribution completed");
//        }

//        static async Task ServeFood()
//        {
//            Console.WriteLine("Food service initiated");
//            await Task.Delay(7000); 
//            Console.WriteLine("Food service completed");
//        }
//    }
//}