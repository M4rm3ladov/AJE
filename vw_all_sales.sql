
CREATE
    /*[ALGORITHM = {UNDEFINED | MERGE | TEMPTABLE}]
    [DEFINER = { user | CURRENT_USER }]
    [SQL SECURITY { DEFINER | INVOKER }]*/
    VIEW `aje_pos`.`vw_all_sales` 
    AS
SELECT DATE_FORMAT(DateInputed, '%m/%d/%Y') AS DateInputed, DATE_FORMAT(transDate, '%m/%d/%Y') AS transDate, '' AS Customers, receipt AS invoice_receipt, Description, Category, Unit, price, qty, line_total, Cashiers, branch_id FROM vw_cash_sales 
UNION
SELECT DATE_FORMAT(DateInputed, '%m/%d/%Y') AS DateInputed, DATE_FORMAT(transDate, '%m/%d/%Y') AS transDate, Customers, invoice AS invoice_receipt, Description, Category, Unit, price, qty, line_total, Cashiers, branch_id FROM vw_credit_sales 
