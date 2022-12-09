import React from "react";


export default function DeletePage(){
    return(
        <form>
            <div class="mb-3">
                <label for="exampleInputEmail1" class="form-label">Id Patient</label>
                <input type="idPatient" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" />
            </div>
            <button type="submit" class="btn btn-primary">Submit</button>
        </form>
    )
}