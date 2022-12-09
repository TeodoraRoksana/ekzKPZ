import React from "react";

import { Link, Outlet } from "react-router-dom";

export default function Layout(){
    return(
        <div id="Root">
            <div id="Navigation">
                <nav className="navbar navbar-expand-lg navbar-light bg-light">
                    <div className="container">
                        <Link className="navbar-brand" to={"/"}>App</Link>
                        <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                            <span className="navbar-toggler-icon"></span>
                        </button>
                        <div className="collapse navbar-collapse" id="navbarSupportedContent">
                            <ul className="navbar-nav me-auto mb-2 mb-lg-0">
                                <li className="nav-item">
                                    <Link className="nav-link active" to={"/"}>Home</Link>
                                </li>
                                <li className="nav-item">
                                    <Link className="nav-link" to={"/history"}>History</Link>
                                </li>
                                <li className="nav-item">
                                    <Link className="nav-link" to={"/insert"}>Insert</Link>
                                </li>
                                <li className="nav-item">
                                    <Link className="nav-link" to={"/update"}>Update</Link>
                                </li>
                                <li className="nav-item">
                                    <Link className="nav-link" to={"/delete"}>Delete</Link>
                                </li>
                            </ul>
                        </div>
                    </div>
                </nav>
            </div>
            <div className="container">
                <Outlet />
            </div>
        </div>
    )
}