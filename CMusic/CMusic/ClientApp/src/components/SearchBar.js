import React, { Component } from 'react';

export class SearchBar extends Component {
    message() {
        //alert('Xin chao');
    }
    render() {
        return (
            <div className="row">
                <div className="col-md-12">
                    <div className="searchbox">
                        <input type="text" name="search" className="searchbox__textbox" />
                        <span className=" searchbox__button btn btn-danger glyphicon glyphicon-search" onClick={this.message()} ></span>
                    </div>
                </div>
            </div>
        );
    }
}
