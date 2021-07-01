using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Facade.III
{
    public class ConverterFacade : IByteArrayConveter, IXmlConverter, IJsonCoverter
    {
        private IByteArrayConveter byteArrayConveter;
        private IXmlConverter xmlConverter;
        private IJsonCoverter jsonCoverter;

        public ConverterFacade(IByteArrayConveter byteArrayConveter, IXmlConverter xmlConverter, IJsonCoverter jsonCoverter)
        {
            this.byteArrayConveter = byteArrayConveter;
            this.xmlConverter = xmlConverter;
            this.jsonCoverter = jsonCoverter;
        }

        public byte[] ToByteArray()
        {
            return byteArrayConveter.ToByteArray();
        }

        public string ToJson()
        {
            return jsonCoverter.ToJson();
        }

        public string ToXml()
        {
            return xmlConverter.ToXml();
        }

    }
}
