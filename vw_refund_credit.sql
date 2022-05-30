DELIMITER $$

USE `aje_pos`$$

DROP VIEW IF EXISTS `vw_refund_credit`$$

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_refund_credit` AS 
SELECT refund.trans_date, invoice , CONCAT(brand.brand_name,' | ',item.item_desc,' | ',item.item_add_desc) AS Description, category.category_name AS Category, unit.unit_name AS Unit, refund_item_dtls.qty, refund_item_dtls.price, refund_item_dtls.sub_total
, CONCAT(c.user_gname, ' ', c.user_surname) AS Cashiers, CONCAT(m.user_gname, ' ', m.user_surname) AS Managers, refund.remarks, inventory.branch_id FROM refund

INNER JOIN order_item_dtls ON order_item_dtls.order_id = refund.order_id
INNER JOIN refund_item_dtls ON refund_item_dtls.refund_id = refund.refund_id
INNER JOIN credit_payment ON credit_payment.order_id = order_item_dtls.order_id

INNER JOIN inventory ON inventory.inventory_id = order_item_dtls.inventory_id
INNER JOIN item ON item.item_id = inventory.item_id
INNER JOIN brand ON brand.brand_id = item.brand_id
INNER JOIN category ON category.category_id = item.category_id
INNER JOIN unit ON unit.unit_id = item.unit_id

INNER JOIN cashier ON cashier.cashier_id = refund.cashier_id
INNER JOIN user_details AS c ON c.user_id = cashier.user_id
INNER JOIN manager ON manager.manager_id = refund.manager_id
INNER JOIN user_details AS m ON m.user_id = manager.user_id

UNION ALL

SELECT refund.trans_date, invoice , service_desc AS Description, '' AS Category,'' AS Unit, refund_svc_dtls.qty, refund_svc_dtls.price, refund_svc_dtls.sub_total
, CONCAT(c.user_gname, ' ', c.user_surname) AS Cashiers, CONCAT(m.user_gname, ' ', m.user_surname) AS Managers,refund.remarks, orders.branch_id FROM refund

INNER JOIN orders ON orders.order_id = refund.order_id
INNER JOIN order_svc_dtls ON order_svc_dtls.order_id = refund.order_id
INNER JOIN refund_svc_dtls ON refund_svc_dtls.refund_id = refund.refund_id
INNER JOIN credit_payment ON credit_payment.order_id = order_svc_dtls.order_id

INNER JOIN service ON service.service_id = refund_svc_dtls.service_id

INNER JOIN cashier ON cashier.cashier_id = refund.cashier_id
INNER JOIN user_details AS c ON c.user_id = cashier.user_id
INNER JOIN manager ON manager.manager_id = refund.manager_id
INNER JOIN user_details AS m ON m.user_id = manager.user_id
