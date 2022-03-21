namespace Aweton.Labs.Cbr.Abstractions;

public interface ICbrLoader
{
  Task<IXmlResult> LoadFor(DateTime date);
}

