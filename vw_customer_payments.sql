SELECT credit_settle.trans_date, credit_settle.receipt, CONCAT(customer_details.customer_gname, ' ', customer_details.customer_surname) AS Customers, pay_amount , CONCAT(C.user_gname, ' ', C.user_surname) AS Cashiers,
CONCAT(M.user_gname, ' ', M.user_surname) AS Managers FROM credit_settle
INNER JOIN manager ON manager.manager_id = credit_settle.manager_id
INNER JOIN cashier ON cashier.cashier_id = credit_settle.cashier_id
INNER JOIN customer_details ON customer_details.customer_id = credit_settle.customer_id
INNER JOIN user_details AS C ON (C.user_id = cashier.user_id) 
INNER JOIN user_details AS M ON (M.user_id = manager.user_id) ORDER BY credit_settle.trans_date, credit_settle.receipt