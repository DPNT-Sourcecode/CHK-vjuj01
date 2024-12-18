using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string? skus)
        {
            int AC = 0 , BC = 0, CC = 0, DC = 0;
            if(string.IsNullOrEmpty(skus)){
                return 0;
            }
            foreach(char c in skus){
                switch (c){
                    case 'A':
                        AC ++;
                        break;
                    case 'B':
                        BC++;
                        break;
                    case 'C':
                        CC++;
                        break;
                    case 'D':
                        DC++;
                        break;
                    default:
                        return -1;
                }
            }
            int ACDivision = AC / 3;
            int ACMod = AC % 3;
            int BCDivision = BC / 2;
            int BCMod = BC % 2;
            return (ACDivision * 130) + (ACMod * 50) + (BCDivision * 45) + (BCMod * 30) + (CC * 20) + (DC * 15);
        }
    }
}


