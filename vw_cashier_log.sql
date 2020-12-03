DELIMITER $$

USE `aje_pos`$$

DROP VIEW IF EXISTS `vw_cashier_log`$$

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_cashier_log` AS 
SELECT
  `users`.`branch_id`       AS `branch_id`,
  `cashier_log`.`log_date`  AS `log_date`,
  CONCAT(`c`.`user_gname`, ' ',`c`.`user_surname`) AS `Cashiers`,
  CONCAT(`m`.`user_gname`, ' ',`m`.`user_surname`) AS `Managers`,
  `cashier_log`.`time_from` AS `time_from`,
  `cashier_log`.`time_to`   AS `time_to`,
  `cashier_log`.`begin_bal` AS `begin_bal`,
  `cashier_log`.`end_bal`   AS `end_bal`
FROM (((((`cashier_log`
       JOIN `cashier`
         ON ((`cashier`.`cashier_id` = `cashier_log`.`cashier_id`)))
      JOIN `manager`
        ON ((`manager`.`manager_id` = `cashier_log`.`manager_id`)))
     JOIN `users`
       ON ((`users`.`user_id` = `cashier`.`user_id`)))
    JOIN `user_details` `c`
      ON ((`c`.`user_id` = `cashier`.`user_id`)))
   JOIN `user_details` `m`
     ON ((`m`.`user_id` = `manager`.`user_id`)))
ORDER BY `cashier_log`.`log_date`,`cashier_log`.`cashier_id`$$

DELIMITER ;