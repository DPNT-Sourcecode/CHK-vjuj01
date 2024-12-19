using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string? skus)
        {
            int AC = 0 , BC = 0, CC = 0, DC = 0, EC = 0, FC = 0;
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
                    case 'E':
                        EC++;
                        break;
                    case 'F':
                        FC++;
                        break;
                    default:
                        return -1;
                }
            }
            int ACDivision1 = AC / 5;
            int ACMod1 = AC % 5;
            int ACDivision2 = ACMod1 / 3;
            int ACMod2 = ACMod1 % 3;            
            int ECDivision = EC / 2;
            if (BC > ECDivision) {BC -= ECDivision;}
            else BC = 0;
            int BCDivision = BC / 2;
            int BCMod = BC % 2;
            int FCDivision = (FC / 3) * 2;
            int FCMod = FC % 3;
            return (ACDivision1 * 200) + (ACDivision2 * 130) + (ACMod2 * 50) + (BCDivision * 45) +
            (BCMod * 30) + (CC * 20) + (DC * 15) + (EC * 40) + ((FCDivision + FCMod) * 10);
        }
    }
}

