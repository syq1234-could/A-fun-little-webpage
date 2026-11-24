#if MACCATALYST
using ObjCRuntime;
using UIKit;

namespace FoodDrinkApp;

public class Program
{
    // This is the main entry point of the Mac Catalyst application.
    static void Main(string[] args)
    {
        UIApplication.Main(args, null, typeof(AppDelegate));
    }
}
#endif
