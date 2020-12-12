DELIMITER $$

USE `aje_pos`$$

DROP VIEW IF EXISTS `vw_refund`$$

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_refund` AS (SELECT refund.trans_date, item.item_code, CONCAT( brand.brand_name, ' | ', item.item_desc, ' | ', item.item_add_desc, ' | ', category.category_name) AS Description, unit.unit_name AS Unit, refund_item_dtls.price, refund_item_dtls.qty, refund_item_dtls.sub_total, 
CONCAT(C.user_gname, ' ', C.user_surname) AS Cashiers, CONCAT(M.user_gname, ' ', M.user_surname) AS Managers, refund.remarks, orders.branch_id FROM refund
INNER JOIN refund_item_dtls ON refund_item_dtls.refund_id = refund.refund_id
INNER JOIN inventory ON inventory.inventory_id = refund_item_dtls.inventory_id
INNER JOIN item ON item.item_id = inventory.item_id
INNER JOIN unit ON unit.unit_id = item.unit_id
INNER JOIN brand ON brand.brand_id = item.brand_id
INNER JOIN category ON category.category_id = item.category_id
INNER JOIN cashier ON cashier.cashier_id = refund.cashier_id
INNER JOIN user_details AS C ON (C.user_id = cashier.user_id)
INNER JOIN manager ON manager.manager_id = refund.manager_id
INNER JOIN user_details AS M ON (M.user_id = manager.manager_id)
INNER JOIN orders ON orders.order_id = refund.order_id) UNION
(SELECT refund.trans_date, service.service_code, service.service_desc AS Description, '' AS Unit,refund_svc_dtls.price, refund_svc_dtls.qty, refund_svc_dtls.sub_total, 
CONCAT(C.user_gname, ' ', C.user_surname) AS Cashiers, CONCAT(M.user_gname, ' ', M.user_surname) AS Managers, refund.remarks, orders.branch_id FROM refund
INNER JOIN refund_svc_dtls ON refund_svc_dtls.refund_id = refund.refund_id
INNER JOIN service ON service.service_id = refund_svc_dtls.service_id
INNER JOIN cashier ON cashier.cashier_id = refund.cashier_id
INNER JOIN user_details AS C ON (C.user_id = cashier.user_id)
INNER JOIN manager ON manager.manager_id = refund.manager_id
INNER JOIN user_details AS M ON (M.user_id = manager.manager_id)
INNER JOIN orders ON orders.order_id = refund.order_id)
