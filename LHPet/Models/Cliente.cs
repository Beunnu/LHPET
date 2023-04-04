namespace LHPet.Models;

public class Cliente
{
    // Aqui são criados atributos de Cliente e seus getters e setters.

    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? Paciente { get; set; }

    /* Aqui é criado o Construtor do Model Cliente e 
    determinado quais parâmetros na criação da instância.*/
    public Cliente(int id, string nome, string cpf, string email, 
    string paciente)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = paciente;
    }

}