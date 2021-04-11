# Currency Exchange Application

This is a C# Console Application that is able to take a ISO currency pair and an amount, and write the exchanged amount.
___

## Task

Using the exchange rates below, denoting the amount Danish kroner (DKK) required to purchase 100 in the mentioned currency,  make a command line tool that is able to take a ISO currency pair and an amount, and write the exchanged amount to the console.


<table>
  <th align="left">
    <tr>
        <td>Currency</td>
        <td>ISO</td>
        <td>Amount</td>
    </tr>
  </th>
  <tr align="left">
    <td>Euro</td>
    <td>EUR</td>
    <td>743,94</td>
  </tr>
  <tr align="left">
    <td>Amerikanske dollar</td>
    <td>USD</td>
    <td>663,11</td>
  </tr>
  <tr align="left">
    <td>Britiske pund</td>
    <td>GBP</td>
    <td>852,85</td>
  </tr>
  <tr align="left">
    <td>Svenske kroner</td>
    <td>SEK</td>
    <td>76,10</td>
  </tr>
  <tr align="left">
    <td>Norske kroner</td>
    <td>NOK</td>
    <td>78,40</td>
  </tr>
  <tr align="left">
    <td>Schweiziske franc</td>
    <td>CHF</td>
    <td>683,58</td>
  </tr>
  <tr align="left">
    <td>Japanske yen</td>
    <td>JPY</td>
    <td>5,9740</td>
  </tr>
</table>

<br>

It is expected that a currency pair can contain any combination of the mentioned currencies (including DKK), e.g. EUR/USD. If a currency pair has the same ISO currency as both main and money, then the passed amount should be returned. If a currency pair contains an unknown currency, then an appropriate error message should be written to console.

It is expected that the code includes tests for the solution elements.
___

## Requirement

Please provide a solution in C#

You may use any frameworks (testing, mocking etc.) as long as it is freeware and available for download from nuget.org or embedded in your solution.

Please don’t integrate with any kind of databases. Use of filesystem is ok, but you are welcome to hardcode the exchange rates supplied.

## Usage

Run the application. Type the currency pair (i.e. DKK/USD) with the desired amount and press Enter.


