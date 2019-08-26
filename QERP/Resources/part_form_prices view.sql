--SQL
CREATE OR REPLACE VIEW part_form_prices AS (
    SELECT
        prt_no,
        pp.ppr_sort_idx,
        CASE
            WHEN pp.ppr_sort_idx = 1 THEN 'RETAIL CDN'
            WHEN pp.ppr_sort_idx = 2 THEN 'RETAIL USD'
            WHEN pp.ppr_sort_idx = 3 THEN 'RETAIL EURO'
            WHEN pp.ppr_sort_idx = 4 THEN 'LEVEL 4'
            WHEN pp.ppr_sort_idx = 5 THEN 'LEVEL 5'
        END AS price_name,
        pp.ppr_price,
        CASE
            WHEN pp.ppr_price <> 0 AND ps.sup_no <> 'A001' THEN (1 - (ps.psp_price / pp.ppr_price))::NUMERIC(17,4)
            WHEN pp.ppr_price <> 0 AND pq.pqt_avg_cost <> 0 AND ps.sup_no = 'A001' THEN (1 - (pq.pqt_avg_cost / pp.ppr_price))::NUMERIC(17,4)
            ELSE 0
        END AS effective_margin,
        CASE 
            WHEN ps.sup_no <> 'A001' THEN ps.psp_price
            ELSE pq.pqt_avg_cost
        END AS avg_cost,
        CASE
            WHEN pp.ppr_std_margin_pct = 999 THEN 0
            ELSE pp.ppr_std_margin_pct
        END AS ppr_std_margin_pct,
        'P' AS std_margin_src,
        pp.ppr_ref_cost,
        pp.ppr_ref_cost_dt,
        pp.ppr_price_chg_dt,
        CASE
            WHEN pp.ppr_min_margin_pct = 999 THEN 0
            ELSE pp.ppr_min_margin_pct
        END AS ppr_min_margin_pct,
        'G' AS min_margin_src,
        p.prt_unit,
        pp.ppr_note,
        pp.usr_no

    FROM part_price pp
    JOIN part p ON p.prt_id = pp.prt_id
    JOIN part_supplier ps ON p.prt_def_sup_idx = ps.psp_idx AND p.prt_id = ps.prt_id
    JOIN part_quantity pq ON p.prt_id = pq.prt_id
    ORDER BY prt_no, ppr_id
);