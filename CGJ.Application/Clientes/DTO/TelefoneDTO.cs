namespace CGJ.Application.Clientes.DTO
{
    public record TelefoneInputDTO(ClienteInputDTO Cliente, string Numero, string Complemento);

    public record TelefoneUpdateDTO(Guid Codigo, ClienteInputDTO Cliente, string Numero, string Complemento);

    public record TelefoneOutputDTO(Guid Codigo, ClienteOutputDTO Cliente, string Numero, string Complemento);
}
