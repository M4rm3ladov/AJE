
SELECT void.trans_date, receipt , CONCAT(brand.brand_name,' | ',item.item_desc,' | ',item.item_add_desc) AS Description, category.category_name AS Category, unit.unit_name AS Unit, order_item_dtls.qty, order_item_dtls.price, order_item_dtls.line_total
, CONCAT(c.user_gname, ' ', c.user_surname) AS Cashiers, CONCAT(m.user_gname, ' ', m.user_surname) AS Managers, void.remarks, inventory.branch_id FROM void

INNER JOIN order_item_dtls ON order_item_dtls.order_id = void.order_id
INNER JOIN cash_payment ON cash_payment.order_id = order_item_dtls.order_id

INNER JOIN inventory ON inventory.inventory_id = order_item_dtls.inventory_id
INNER JOIN item ON item.item_id = inventory.item_id
INNER JOIN brand ON brand.brand_id = item.brand_id
INNER JOIN category ON category.category_id = item.category_id
INNER JOIN unit ON unit.unit_id = item.unit_id
INNER JOIN cashier ON cashier.cashier_id = void.cashier_id
INNER JOIN user_details AS c ON c.user_id = cashier.user_id
INNER JOIN manager ON manager.manager_id = void.manager_id
INNER JOIN user_details AS m ON m.user_id = manager.user_id

UNION ALL

SELECT void.trans_date, receipt, service_desc AS Description, '' AS Category ,'' AS Unit, order_svc_dtls.qty, order_svc_dtls.price, order_svc_dtls.line_total
, CONCAT(c.user_gname, ' ', c.user_surname) AS Cashiers, CONCAT(m.user_gname, ' ', m.user_surname) AS Managers, void.remarks, orders.branch_id FROM void

INNER JOIN orders ON void.order_id = orders.order_id
INNER JOIN order_svc_dtls ON order_svc_dtls.order_id = void.order_id
INNER JOIN cash_payment ON cash_payment.order_id = orders.order_id

INNER JOIN service ON service.service_id = order_svc_dtls.service_id
INNER JOIN cashier ON cashier.cashier_id = void.cashier_id
INNER JOIN user_details AS c ON c.user_id = cashier.user_id
INNER JOIN manager ON manager.manager_id = void.manager_id
INNER JOIN user_details AS m ON m.user_id = manager.user_id





