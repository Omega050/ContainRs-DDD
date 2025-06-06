namespace ContainRs.Clientes.Cadastro;

public class Cliente
{
    private Cliente() { } // EF Core

    public Cliente(string nome, Email email, string cPF)
    {
        Nome = nome;
        Email = email;
        CPF = cPF;
    }

    public Guid Id { get; set; }
    public string Nome { get; private set; }
    public Email Email { get; private set; }
    public string CPF { get; private set; }
    public string? Celular { get; set; }
    public ICollection<EnderecoCliente> Enderecos { get; set; }

    public EnderecoCliente AddEndereco(EnderecoCliente endereco)
    {
        Enderecos ??= [];
        Enderecos.Add(endereco);
        return endereco;
    }

    public void RemoveEndereco(EnderecoCliente endereco)
    {
        Enderecos.Remove(endereco);
    }

    public EnderecoCliente AddEndereco(string cep, string rua, string? numero, string? complemento, string? bairro, string municipio, UnidadeFederativa? estado)
    {
        var endereco = new EnderecoCliente
        {
            CEP = cep,
            Rua = rua,
            Numero = numero,
            Complemento = complemento,
            Bairro = bairro,
            Municipio = municipio,
            Estado = estado
        };
        return AddEndereco(endereco);
    }
}
