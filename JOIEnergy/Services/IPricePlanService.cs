using System.Collections.Generic;

namespace JOIEnergy.Services
{
    public interface IPricePlanService
    {
        Dictionary<string, decimal> GetConsumptionCostOfElectricityReadingsForEachPricePlan(string smartMeterId);

        /// <summary>
        /// Método responsável por calcular o custo de consumo de energia elétrica para o último intervalo de leitura.
        /// </summary>
        /// <param name="smartMeterId"></param>
        /// <returns></returns>
        decimal GetConsumptionCostLastWeek(string smartMeterId);
    }
}