namespace Aweton.Labs.Cbr.Abstractions;

public interface ICbrHttpGet
{
  Task<string> GetXmlDailyAsp(DateTime date);
}
