namespace Aweton.Labs.Cbr.Abstractions;

public interface IXmlResult
{
  byte[] GetHash();

  DateTime ADate { get; }
  IList<IXmlRow> Rates { get; }
}

