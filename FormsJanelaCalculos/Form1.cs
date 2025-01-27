namespace FormsJanelaCalculos
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }

        private void bttCalcular_Click ( object sender , EventArgs e )
        {
            lbxResumo.Items.Clear();
            RadioButton rbnTurno = gbxTurno.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            RadioButton rbnCategoria = gbxCategoria.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);

            RealizarProcessamento(rbnTurno , rbnCategoria , Convert.ToDouble(txtHoraTrabalhada.Text) , Convert.ToDouble(txtSalario.Text));
        }

        private void RealizarProcessamento ( RadioButton? rbnTurno , RadioButton? rbnCategoria , double horasTrabalhadas , double salarioMinimo )
        {
            double valorCoeficiente = GetCoeficiente(rbnTurno);
            double valorGratificacao = GetGratificacao(rbnTurno , horasTrabalhadas);
            double valorSalarioBruto = horasTrabalhadas * valorCoeficiente;
            double valorImposto = GetImposto(rbnCategoria , valorSalarioBruto);
            double valorAuxilioAlimentacao = GetValorAuxilioAlimentacao(rbnCategoria , valorSalarioBruto , salarioMinimo);
            double valorSalarioLiquido = (valorSalarioBruto + (valorGratificacao + valorAuxilioAlimentacao)) - valorImposto;

            ApresentarResultados(valorCoeficiente , valorSalarioBruto , valorImposto , valorGratificacao , valorAuxilioAlimentacao , valorSalarioLiquido);
        }

        private void ApresentarResultados ( double valorCoeficiente , double valorSalarioBruto , double valorImposto , double valorGratificacao , double valorAuxilioAlimentacao , double valorSalarioLiquido )
        {
            txtSituacaoSalarial.Text =  GetSituacaoEstagiario(valorSalarioLiquido);
            lbxResumo.Items.Add(String.Format("{0, -29}{1,12:c}", "Valor do Coeficiente:" , valorCoeficiente));
            lbxResumo.Items.Add(String.Format("{0, -29}{1,12:c}" , "Valor do Salário Bruto:" , valorSalarioBruto));
            lbxResumo.Items.Add(String.Format("{0, -29}{1,12:c}" , "Valor do Imposto:" , valorImposto));
            lbxResumo.Items.Add(String.Format("{0, -29}{1,12:c}" , "Valor da Gratificação:" , valorGratificacao));
            lbxResumo.Items.Add(String.Format("{0, -29}{1,12:c}" , "Valor do Auxílio Alimentação:" , valorAuxilioAlimentacao));
            lbxResumo.Items.Add(String.Format("{0, -29}{1,12:c}" , "Valor do Salário Líquido:" , valorSalarioLiquido));
        }

        private string GetSituacaoEstagiario ( double valorSalarioLiquido )
        {
            if(valorSalarioLiquido < 350)
            {
                return "Mal remunerado";
            }
            else if (valorSalarioLiquido >= 350 && valorSalarioLiquido < 600)
            {
                return "Normal";
            }
            else
            {
                return "Bem remunerado";
            }
        }

        private double GetValorAuxilioAlimentacao ( RadioButton? rbnCategoria , double valorSalarioBruto , double salarioMinimo )
        {
            double valorAuxilioAlimentacao = (valorSalarioBruto / 3) / 2;
            if (rbnCategoria.Text.Equals("Calouro") && (valorSalarioBruto < (salarioMinimo / 2)))
                valorAuxilioAlimentacao = (valorSalarioBruto / 3);
            return valorAuxilioAlimentacao;
        }

        private double GetImposto ( RadioButton? rbnCategoria , double valorSalarioBruto )
        {
            double valorImposto = 0;
            switch (rbnCategoria.Text)
            {
                case "Calouro":
                    if (valorSalarioBruto < 300)
                    {
                        valorImposto = valorSalarioBruto * 0.01;
                    }
                    else
                    {
                        valorImposto = valorSalarioBruto * 0.02;
                    }
                    break;
                case "Veterano":
                    if (valorSalarioBruto < 400)
                    {
                        valorImposto = valorSalarioBruto * 0.03;
                    }
                    else
                    {
                        valorImposto = valorSalarioBruto * 0.04;
                    }
                    break;
            }
            return valorImposto;
        }

        private double GetGratificacao ( RadioButton? rbnTurno , double horasTrabalhadas )
        {
            double valorGratificacao = 30;
            if (rbnTurno.Text == "Noturno" && horasTrabalhadas > 80)
            {
                valorGratificacao = 50;
            }
            return valorGratificacao;
        }

        private double GetCoeficiente ( RadioButton? rbnTurno )
        {
            double valorCoeficiente = 0;

            switch (rbnTurno.Text)
            {
                case "Matutino":
                    valorCoeficiente = Convert.ToDouble(txtSalario.Text) * 0.01;
                    break;
                case "Vespertino":
                    valorCoeficiente = Convert.ToDouble(txtSalario.Text) * 0.02;
                    break;
                case "Noturno":
                    valorCoeficiente = Convert.ToDouble(txtSalario.Text) * 0.03;
                    break;

            }
            return valorCoeficiente;
        }
    }
}
