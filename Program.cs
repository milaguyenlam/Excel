public abstract class Cell
{
    protected int? Value;
    public int GetValue()
    {
        if (Value.HasValue)
        {
            return Value.Value;
        }
        return Evaluate();
    }
    protected abstract int Evaluate();
}

public class ValueCell : Cell
{
    public ValueCell(int value)
    {
        Value = value;
    }
    protected override int Evaluate()
    {
        // Should never be called, create specific exception
        throw new NotImplementedException();
    }
}

public class FormulaCell : Cell
{
    private string[] tokenizedFormula;
    private Sheet sheet;
    private bool isBeingEvaluated = false;
    public FormulaCell(string formula, Sheet sheet)
    {
        this.tokenizedFormula = Tokenize(formula);
        this.sheet = sheet;
    }

    public bool IsBeingEvaluated()
    {
        return isBeingEvaluated;
    }

    protected override int Evaluate()
    {
        // TODO: Implement infix evaluation
        isBeingEvaluated = true;

        isBeingEvaluated = false;
        // TODO: Set value
        throw new NotImplementedException();
    }
    private string[] Tokenize(string text)
    {
        throw new NotImplementedException();
    }

}

public class Sheet
{
    private Dictionary<string, Sheet> additionalSheets = new Dictionary<string, Sheet>();
    public Sheet(string filename)
    {
        var sr = new StreamReader(filename);
        Parse(sr);
    }
    private void Parse(StreamReader sr)
    {
        throw new NotImplementedException();
    }
    public void Evaluate()
    {
        throw new NotImplementedException();
    }
    public Cell GetCell(string code)
    {
        throw new NotImplementedException();
    }
    private void CheckCell()
    {
        throw new NotImplementedException();
    }
}

class Excel
{
    static void Main(string[] args)
    {
        string filename = "";
        Sheet sheet = new Sheet(filename);
        sheet.Evaluate();
    }
}