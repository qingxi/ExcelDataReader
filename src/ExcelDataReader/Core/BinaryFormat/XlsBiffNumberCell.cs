namespace ExcelDataReader.Core.BinaryFormat
{
    /// <summary>
    /// Represents a floating-point number 
    /// </summary>
    internal class XlsBiffNumberCell : XlsBiffBlankCell
    {
        internal XlsBiffNumberCell(byte[] bytes, uint offset, int biffVersion)
            : base(bytes, offset)
        {
            if (biffVersion == 2)
            {
                Value = ReadDouble(0x7);
            }
            else
            {
                Value = ReadDouble(0x6);
            }
        }

        /// <summary>
        /// Gets the value of this cell
        /// </summary>
        public double Value { get; }
    }
}