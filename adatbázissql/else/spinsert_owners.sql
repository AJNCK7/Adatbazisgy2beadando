create or replace procedure spinsert_owners(
    p_id in owners.id%type,
    p_familyname in owners.familyname%type,
    p_surname in owners.surname%type,
    p_birthdate in owners.birthdate%type,
    p_zipcode in owners.zipcode%type,
    p_city in owners.city%type,
    p_address in owners.address%type,
    p_phonenumber in owners.phonenumber%type,
    p_email in owners.email%type,
    p_out_rowcnt out int
)

authid definer
as 
    v_check_zipcode int;
    v_check_phonenumber int;
begin
    p_out_rowcnt := 0;
        v_check_zipcode := sf_check_zipcode(p_zipcode);
        v_check_phonenumber := sf_check_phonenumber(p_phonenumber);
        if v_check_zipcode = 1 then
            if v_check_phonenumber = 1 then
                insert into owners
                    (id, familyname,surname,birthdate,zipcode,city,address,phonenumber,email)
                    values
                    (p_id,p_familyname,p_surname,p_birthdate,p_zipcode, p_city, p_address,p_phonenumber,p_email);
                    p_out_rowcnt := SQL%rowcount;
                    commit;
            end if;
        end if;
end spinsert_owners;
        