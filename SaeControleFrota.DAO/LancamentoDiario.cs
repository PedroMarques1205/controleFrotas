//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaeControleFrota.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class LancamentoDiario
    {
        public int idTipoAtividade { get; set; }
        public string placa { get; set; }
        public string motorista { get; set; }
        public System.DateTime data { get; set; }
        public Nullable<System.TimeSpan> horarioChegada { get; set; }
        public Nullable<System.TimeSpan> horarioSaida { get; set; }
        public Nullable<double> kmRodados { get; set; }
        public string nomeAtividade { get; set; }
        public Nullable<bool> isResponsabilidadeSae { get; set; }
        public Nullable<double> descontoDiarias { get; set; }
        public double valorManutencao { get; set; }
        public Nullable<double> litrosOleoUsado { get; set; }
        public Nullable<double> valorLitro { get; set; }
        public Nullable<double> valorTotalLitro { get; set; }
        public Nullable<double> valorDiaria { get; set; }
    
        public virtual Veiculo Veiculo { get; set; }
    }
}
