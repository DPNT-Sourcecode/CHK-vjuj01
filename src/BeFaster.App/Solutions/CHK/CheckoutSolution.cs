using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        public static int ComputePrice(string? skus)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            if(string.IsNullOrEmpty(skus)){
                return 0;
            }
            foreach(char c in skus){
                if (char.IsUpper(c)){
                    if (dict.ContainsKey(c)){
                        dict[c]++;
                    }
                    else{
                        dict[c] = 1;
                    }
                }                
            }
            int ACDivision1 = dict['A'] / 5;
            int ACMod1 = dict['A'] % 5;
            int ACDivision2 = ACMod1 / 3;
            int ACMod2 = ACMod1 % 3;            
            int ECDivision = dict['E'] / 2;
            if (dict['B'] > ECDivision) {dict['B'] -= ECDivision;}
            else dict['B'] = 0;
            int BCDivision = dict['B'] / 2;
            int BCMod = dict['B'] % 2;
            int FCDivision = (dict['F'] / 3) * 2;
            int FCMod = dict['F'] % 3;
            return (ACDivision1 * 200) + (ACDivision2 * 130) + (ACMod2 * 50) + (BCDivision * 45) +
            (BCMod * 30) + (dict['C'] * 20) + (dict['D'] * 15) + (dict['E'] * 40) + ((FCDivision + FCMod) * 10);
        }
    }
}
