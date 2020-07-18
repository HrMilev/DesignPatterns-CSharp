using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        Contractor contractor = new Contractor();
        IBuilder builderX = new BuilderLuxHouse();
        IBuilder builderY = new BuilderHouse();

        contractor.Contract(builderX);
        builderX.GetHouse().Show();

        contractor.Contract(builderY);
        builderY.GetHouse().Show();

    }
}
