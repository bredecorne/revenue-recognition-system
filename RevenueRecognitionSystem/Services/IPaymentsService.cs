using Microsoft.AspNetCore.Mvc;
using RevenueRecognitionSystem.DTOs;
using RevenueRecognitionSystem.Models;

namespace RevenueRecognitionSystem.Services;

public interface IPaymentsService
{
    Task<decimal?> CalculateRemainingToPay(int contractId);

    Task<(bool Success, IActionResult Response, ContractPayment Payment)> AddPayment(
        CreateContractPaymentDto paymentDto);

    Task<decimal> CalculateIncomeRecognized();
    Task<decimal?> CalculateIncomeRecognized(int softwareId);
    Task<(bool Success, IActionResult Response, decimal ConvertedIncome)> CalculateIncomeRecognized(string currency);
    Task<decimal> CalculateExpectedIncome();
}