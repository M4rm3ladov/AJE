
CREATE
    /*[ALGORITHM = {UNDEFINED | MERGE | TEMPTABLE}]
    [DEFINER = { user | CURRENT_USER }]
    [SQL SECURITY { DEFINER | INVOKER }]*/
    VIEW `aje_pos`.`vw_cash_in` 
    AS
SELECT users.branch_id, cash_in.trans_date, CONCAT(C.user_gname, ' ', C.user_surname) AS Cashiers, CONCAT(M.user_gname, ' ',M.user_surname) AS Managers, cash_in.amount, cash_in.remarks FROM cash_in
INNER JOIN cashier ON cashier.cashier_id = cash_in.cashier_id
INNER JOIN manager ON manager.manager_id = cash_in.manager_id
INNER JOIN users ON users.user_id = cashier.user_id
INNER JOIN user_details AS M ON (M.user_id= manager.user_id)
INNER JOIN user_details AS C ON (C.user_id = cashier.user_id)
INNER JOIN branch ON branch.branch_id = users.branch_id;
 
