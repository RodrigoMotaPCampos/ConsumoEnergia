
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProjetoConsumoEnergiaWinForms.Models
{
    public class ClienteConverter : JsonConverter<Cliente>
    {
        public override Cliente Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            var jsonObject = jsonDoc.RootElement;

            string tipo = jsonObject.GetProperty("TipoCliente").GetString();
            string nome = jsonObject.GetProperty("Nome").GetString();
            string documento = jsonObject.GetProperty("Documento").GetString();

            Cliente cliente = tipo == "Pessoa Física" ? new PessoaFisica(nome, documento) : new PessoaJuridica(nome, documento);
            cliente.Contas = JsonSerializer.Deserialize<List<ContaEnergia>>(jsonObject.GetProperty("Contas").GetRawText(), options);
            return cliente;
        }

        public override void Write(Utf8JsonWriter writer, Cliente value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (object)value, value.GetType(), options);
        }
    }
}
