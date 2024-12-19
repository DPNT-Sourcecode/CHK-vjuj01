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
            for (char ch = 'A'; ch <= 'Z'; ch++){
                dict[ch] = 0;
            }
            foreach(char c in skus){
                if (char.IsUpper(c)){
                    if (dict.ContainsKey(c)){
                        dict[c]++;
                    }
                }
                else{
                    return -1;
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
            int HCDivision1 = dict['H'] / 10;
            int HCMod1 = dict['H'] % 10;
            int HCDivision2 = HCMod1 / 5;
            int HCMod2 = HCMod1 % 5;
            int KCDivision = dict['K'] / 2;
            int KCMod = dict['K'] % 2;
            int NCDivision = dict['N'] / 3;
            if (dict['M'] > NCDivision) {dict['M'] -= NCDivision;}
            else dict['M'] = 0;
            int PCDivision = dict['P'] / 5;
            int PCMod = dict['P'] % 5;
            int RCDivision = dict['R'] / 3;
            if (dict['Q'] > RCDivision) {dict['Q'] -= RCDivision;}
            else dict['Q'] = 0;
            int QCDivision = dict['Q'] / 3;
            int QCMod = dict['Q'] % 3;
            int UCDivision = (dict['U'] / 4) * 3;
            int UCMod = dict['U'] % 4;
            int VCDivision1 = dict['V'] / 3;
            int VCMod1 = dict['V'] % 3;
            int VCDivision2 = VCMod1 / 2;
            int VCMod2 = VCMod1 % 2;

            return (ACDivision1 * 200) + (ACDivision2 * 130) + (ACMod2 * 50) + (BCDivision * 45) +
            (BCMod * 30) + (dict['C'] * 20) + (dict['D'] * 15) + (dict['E'] * 40) +
            ((FCDivision + FCMod) * 10) + (dict['G'] * 20) + (HCDivision1 * 80) + (HCDivision2 * 45) + (HCMod2 * 10) +
            (dict['I'] * 35) + (dict['J'] * 60) + (KCDivision * 150) + (KCMod * 80) + (dict['L'] * 90) +
            (dict['M'] * 15) + (dict['N'] * 40) + (dict['O'] * 10) + (PCDivision * 200) + (PCMod * 50) +
            (QCDivision * 80) + (QCMod * 30) + (dict['R'] * 50) + (dict['S'] * 30) + (dict['T'] * 20) +
            ((UCDivision + UCMod) * 40) + (VCDivision1 * 130) + (VCDivision2 * 90) + (VCMod2 * 50) +
            (dict['W'] * 20) + (dict['X'] * 90) + (dict['Y'] * 10) + (dict['Z'] * 50);
        }
    }
}




