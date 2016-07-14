using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using mz.betainteractive.sigeas.DataSets;
using mz.betainteractive.sigeas.Models.Entities;
using mz.betainteractive.sigeas.model.basic;

namespace mz.betainteractive.sigeas.Utilities {
    class ReportsModelConverter {
        public static DataTable CreateMonthWorkTable() {
            DataTable table = new DataTable("MonthWork");
                        
            table.Columns.Add("Id");
            table.Columns.Add("Order");
            table.Columns.Add("Year");
            table.Columns.Add("Name");
            table.Columns.Add("First");
            table.Columns.Add("Last");

            return table;
        }

        public static DataTable CreateDepartamentoTable() {
            DataTable table = new DataTable("Departamento");

            table.Columns.Add("Id");
            table.Columns.Add("Code");
            table.Columns.Add("Name");

            return table;
        }

        public static DataTable CreateCategoriaTable() {
            DataTable table = new DataTable("Categoria");

            table.Columns.Add("Id");
            table.Columns.Add("Code");
            table.Columns.Add("Name");

            return table;
        }

        public static DataTable CreateFuncionarioTable() {
            DataTable table = new DataTable("Funcionario");

            table.Columns.Add("Id");
            table.Columns.Add("Code");
            table.Columns.Add("Name");
            table.Columns.Add("Gender");
            table.Columns.Add("DateOfBirth");
            table.Columns.Add("Email");
            table.Columns.Add("Nuit");
            table.Columns.Add("DepartamentoId");
            table.Columns.Add("CategoriaId");

            return table;
        }

        public static DataTable CreateMonthlyAttCalcsTable() {
            DataTable table = new DataTable("MonthlyAttCalcs");

            table.Columns.Add("Id");
            table.Columns.Add("FuncionarioId");
            table.Columns.Add("MonthId");
            table.Columns.Add("Year");
            table.Columns.Add("Order");
            table.Columns.Add("First");
            table.Columns.Add("Last");
            table.Columns.Add("Holidays");
            table.Columns.Add("TotalWorkDays");
            table.Columns.Add("TotalWorkHours");
            table.Columns.Add("WorkedDays");
            table.Columns.Add("WorkedHours");
            table.Columns.Add("AbsentDays");
            table.Columns.Add("AbsentHours");
            table.Columns.Add("OvertimeHours");
            table.Columns.Add("IsOnVacation");

            return table;
        }

        public static DataTable CreateDailyAttCalcsTable() {
            DataTable table = new DataTable("DailyAttCalcs");

            table.Columns.Add("Id");
            table.Columns.Add("FuncionarioId");
            table.Columns.Add("Year");
            table.Columns.Add("Date");
            table.Columns.Add("Month");
            table.Columns.Add("Entrada");
            table.Columns.Add("Saida");
            table.Columns.Add("EntradaAtrasada");
            table.Columns.Add("SaidaAdiantada");
            table.Columns.Add("WorkedHours");
            table.Columns.Add("OvertimeHours");
            table.Columns.Add("AbsentHours");
            table.Columns.Add("IsDaywork");
            table.Columns.Add("IsHoliday");
            table.Columns.Add("IsOnVacation");
            table.Columns.Add("IsPresent");
            table.Columns.Add("IsAbsent");
            table.Columns.Add("IsAuthorizedAbsent");

            return table;
        }

        public static void AddMonthWork(ReportsModel dataSet, List<MonthWork> monthWorks) {
            var table = dataSet.Tables["MonthWork"];
            
            foreach (var item in monthWorks) {
                var row = table.NewRow();

                row["Id"] = item.Id;
                row["Order"] = item.Order;
                row["Year"] = item.Year;
                row["Name"] = item.ToString();
                row["First"] = item.First;
                row["Last"] = item.Last;

                table.Rows.Add(row);
            }
        }

        public static void AddDepartamento(ReportsModel dataSet, List<Departamento> departaments) {
            var table = dataSet.Tables["Departamento"];

            foreach (var item in departaments) {
                var row = table.NewRow();

                row["Id"] = item.Id;
                row["Code"] = item.Code;
                row["Name"] = item.Nome;

                table.Rows.Add(row);
            }
        }

        public static void AddCategoria(ReportsModel dataSet, List<Categoria> categorias) {
            var table = dataSet.Tables["Categoria"];

            foreach (var item in categorias) {
                var row = table.NewRow();

                row["Id"] = item.Id;
                row["Code"] = item.Code;
                row["Name"] = item.Nome;

                table.Rows.Add(row);
            }
        }

        public static void AddFuncionario(ReportsModel dataSet, List<Funcionario> funcionarios) {
            var table = dataSet.Tables["Funcionario"];

            foreach (var item in funcionarios) {
                var row = table.NewRow();

                row["Id"] = item.Id;
                row["Code"] = item.Code;
                row["Name"] = item.Nome;
                row["Gender"] = item.Sexo;
                row["DateOfBirth"] = item.DataDeNascimento.HasValue ? item.DataDeNascimento.Value : DateTime.Now;
                row["Email"] = item.Email;
                row["Nuit"] = item.Nuit;
                row["DepartamentoId"] = item.Departamento.Id;
                row["CategoriaId"] = item.Categoria.Id;

                table.Rows.Add(row);
            }
        }

        public static void AddMonthlyAttCalcs(ReportsModel dataSet, List<MonthlyAttCalcs> monthlyAttCalcs) {
            var table = dataSet.Tables["MonthlyAttCalcs"];

            foreach (var item in monthlyAttCalcs) {
                var row = table.NewRow();                

                row["Id"] = item.Id;
                row["FuncionarioId"] = item.Funcionario.Id;
                row["MonthId"] = item.Month.Id;
                row["Year"] = item.Ano;
                row["Order"] = item.Order;
                row["First"] = item.First;
                row["Last"] = item.Last;
                row["Holidays"] = item.Holidays;
                row["TotalWorkDays"] = item.TotalWorkDays;
                row["TotalWorkHours"] = new Hora(item.TotalWorkHours, item.TotalWorkMins).ToString();
                row["WorkedDays"] = item.WorkedDays;
                row["WorkedHours"] = new Hora(item.WorkedHours, item.WorkedMins).ToString();
                row["AbsentDays"] = item.AbsentDays;
                row["AbsentHours"] = new Hora(item.AbsentHours, item.AbsentMins).ToString();
                row["OvertimeHours"] = new Hora(item.TotalOvertimeHours, item.TotalOvertimeMins).ToString();
                row["IsOnVacation"] = item.OnVacation;

                table.Rows.Add(row);
            }
        }

        public static void AddDailyAttCalcs(ReportsModel dataSet, List<DailyAttCalcs> dailyAttCalcs) {
            var table = dataSet.Tables["DailyAttCalcs"];

            foreach (var item in dailyAttCalcs) {
                var row = table.NewRow();
                
                row["Id"] = item.Id;
                row["FuncionarioId"] = item.Funcionario.Id;
                row["Year"] = item.Ano;
                row["Date"] = item.Data;
                row["MonthId"] = item.Month.Id;
                row["Entrada"] = item.Entrada;
                row["Saida"] = item.Saida;
                row["EntradaAtrasada"] = item.EntradaAtrasada;
                row["SaidaAdiantada"] = item.SaidaAdiantada;
                row["WorkedHours"] = new Hora(item.TrabalhouHoras, item.TrabalhouMins).ToString();
                row["OvertimeHours"] = new Hora(item.HrExtrasHoras, item.HrExtrasMins).ToString();
                row["AbsentHours"] = new Hora(item.AusenteHoras, item.AusenteMins).ToString();
                row["IsDaywork"] = item.IsDayWork;
                row["IsHoliday"] = item.IsFeriado;
                row["IsOnVacation"] = item.IsEmFerias;
                row["IsPresent"] = item.IsPresente;
                row["IsAbsent"] = item.Ausente;
                row["IsAuthorizedAbsent"] = item.IsAusenciaAutorizada;

                table.Rows.Add(row);
            }
        }
    }
}
