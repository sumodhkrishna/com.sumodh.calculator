namespace com.sumodh.calculator.Common
{
    public class ArithmaticService
    {
        public static decimal Add(ValuesDTO valuesDTO)
        {
            return valuesDTO.Value1 + valuesDTO.Value2;
        }
        public static decimal Division(ValuesDTO valuesDTO)
        {
            return valuesDTO.Value1 / valuesDTO.Value2;
        }
        public static decimal Subtract(ValuesDTO valuesDTO)
        {
            return valuesDTO.Value1 - valuesDTO.Value2;
        }
        public static decimal Multiply(ValuesDTO valuesDTO)
        {
            return valuesDTO.Value1 * valuesDTO.Value2;
        }
    }
}
