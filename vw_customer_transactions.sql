
CREATE
    /*[ALGORITHM = {UNDEFINED | MERGE | TEMPTABLE}]
    [DEFINER = { user | CURRENT_USER }]
    [SQL SECURITY { DEFINER | INVOKER }]*/
    VIEW `aje_pos`.`vw_customer_transactions` 
    AS
((SELECT CONCAT(customer_details.customer_gname, ' ', customer_details.customer_surname, ' ',customer_details.customer_suffix) AS Customers, customer.customer_id,credit_payment.trans_date, credit_payment.pay_amount, credit_payment.invoice, 
CONCAT(brand.brand_name, ' | ', item.item_desc, ' | ', item.item_add_desc) AS DESCRIPTION, category.category_name AS Category, unit.unit_name AS Unit,
order_item_dtls.price, order_item_dtls.qty, order_item_dtls.line_total, CONCAT(user_details.user_gname, ' ', user_details.user_surname, ' ', user_details.user_suffix) AS Cashiers, orders.branch_id
FROM orders 
INNER JOIN credit_payment ON credit_payment.order_id = orders.order_id
INNER JOIN order_item_dtls ON order_item_dtls.order_id = orders.order_id
INNER JOIN inventory ON inventory.inventory_id = order_item_dtls.inventory_id
INNER JOIN item ON item.item_id = inventory.item_id
INNER JOIN category ON category.category_id = item.category_id
INNER JOIN unit ON unit.unit_id = item.unit_id
INNER JOIN cashier ON credit_payment.cashier_id = cashier.cashier_id
INNER JOIN user_details ON user_details.user_id = cashier.user_id
INNER JOIN brand ON brand.brand_id = item.brand_id 
INNER JOIN customer ON customer.customer_id = credit_payment.customer_id
INNER JOIN customer_details ON customer_details.customer_id = credit_payment.customer_id) UNION

(SELECT CONCAT(customer_details.customer_gname, ' ', customer_details.customer_surname, ' ',customer_details.customer_suffix) AS Customers, customer.customer_id, credit_payment.trans_date, credit_payment.pay_amount,credit_payment.invoice, 
service.service_desc AS DESCRIPTION, '' AS Category, '' AS Unit,
order_svc_dtls.price, order_svc_dtls.qty, order_svc_dtls.line_total, CONCAT(user_details.user_gname, ' ', user_details.user_surname, ' ', user_details.user_suffix) AS Cashiers, orders.branch_id
FROM orders INNER JOIN credit_payment ON credit_payment.order_id = orders.order_id
INNER JOIN order_svc_dtls ON order_svc_dtls.order_id = orders.order_id
INNER JOIN service ON service.service_id = order_svc_dtls.service_id
INNER JOIN cashier ON credit_payment.cashier_id = cashier.cashier_id
INNER JOIN user_details ON user_details.user_id = cashier.user_id
INNER JOIN customer ON customer.customer_id = credit_payment.customer_id
INNER JOIN customer_details ON customer_details.customer_id = credit_payment.customer_id) ORDER BY trans_date, invoice);
