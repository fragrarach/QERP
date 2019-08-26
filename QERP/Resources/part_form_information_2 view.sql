--SQL
CREATE OR REPLACE VIEW part_form_information_2 AS (
    SELECT
        p.prt_no,
        CASE
            WHEN p.pca_no = 0 THEN ' '
            WHEN p.pca_no = -1 THEN ' '
        END AS pca_no,
        p.prt_det_prt_no,
        (
            SELECT psp_part_no 
            FROM part_supplier 
            WHERE psp_idx = p.prt_def_sup_idx 
            AND prt_id = p.prt_id
        ),
        p.prt_del_delay,
        p.prt_upc,
        p.prt_dsgn_no,
        p.prt_issue_no,
        p.prt_dept_no,
        p.prt_seq,
        p.prt_lpp,
        p.prt_ppp,
        p.prt_inv_package,
        p.prt_creation_dt,
        CASE
            WHEN p.prt_valid_profit = 0 THEN 'Use the Group Validation'
            WHEN p.prt_valid_profit = 1 THEN 'Do Not Validate'
            WHEN p.prt_valid_profit = 2 THEN 'Visual Warning Only'
            WHEN p.prt_valid_profit = 3 THEN 'Force an Authorization'
        END AS prt_valid_profit,
        p.prt_gtin_prt_no,
        p.prt_unit,
        p.prt_weight,
        p.prt_calc_weight,
        p.prt_volume,
        p.prt_surface,
        p.prt_stt_ax1,
        p.prt_stt_ax2,
        p.prt_stt_lost_pct,
        p.prt_generated,
        p.prt_active,
        CASE
            WHEN p.prt_allow_bo = 'O' THEN TRUE
            WHEN p.prt_allow_bo = 'N' THEN FALSE
        END AS prt_allow_bo,
        p.prt_prnt_stats,
        p.prt_use_lots
        
    FROM part p
    ORDER BY prt_no
);