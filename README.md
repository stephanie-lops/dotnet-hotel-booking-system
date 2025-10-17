# Sistema de Reservas de Hotel – Desafio .NET C#  
www.dio.me

Este projeto é minha implementação de um **sistema de hospedagem**, desenvolvido durante a **trilha .NET da DIO**, utilizando C# e princípios de POO.  

## Objetivo
Desenvolver um sistema capaz de:
- Cadastrar hóspedes (`Pessoa`) e suítes (`Suite`);  
- Realizar reservas (`Reserva`) com validações de capacidade;  
- Calcular corretamente o valor da diária, aplicando desconto para reservas longas.

## Funcionalidades que implementei
- **Validação de capacidade:** não é possível reservar uma suíte com mais hóspedes do que sua capacidade;  
- **Cálculo de hóspedes:** o sistema retorna a quantidade total de hóspedes cadastrados;  
- **Cálculo da diária:** retorna o valor total da reserva (dias × valor da diária) e aplica desconto de 10% para reservas de 10 dias ou mais.

## Tecnologias e conceitos aplicados
- C# e .NET 9 (Console App);  
- Programação orientada a objetos: classes `Pessoa`, `Suite` e `Reserva`;  
- Tratamento de exceções para validações de negócios;  
- Uso de listas para armazenar hóspedes e gerenciamento de dados da reserva.

## Resultado
O sistema está funcional, permite cadastrar suítes e hóspedes, realiza reservas respeitando todas as regras de negócio, e calcula corretamente o valor das diárias com desconto quando aplicável.  

![Diagrama de classe estacionamento](diagrama_classe_hotel.png)


## Regras e validações
1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.