import { benefit } from "./benefit";
export type stock = {
    Id: number;
    StockId:number;
    Name: string
    Acronym:string;
    CurrentPrice:number;
    MarketCap:number
    TotalShares:number;
    Investors:number;
    Benefit: benefit;
}