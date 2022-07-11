import React, { lazy } from "react";
import { Route, Switch } from "react-router-dom";
import BookList from "../pages/booklisting";
import EditBook from "../pages/booklist/editBook";
import Cart from "../pages/cart";
import { RoutePaths } from "../utils/enum";
import PrivateRoute from "./PrivateRoute";
// import PrivateRoute from "./PrivateRoute";

//component lazy loading
const Login = lazy(() => import("../pages/Login/index"));
const Register = lazy(() => import("../pages/register/index"));
const Book = lazy(() => import("../pages/booklist"));

const AppRoutes: React.FC = () => {
	return (
		<Switch>
			<Route exact path={RoutePaths.Login} component={Login} />
			<Route exact path={RoutePaths.Register} component={Register} />
			<Route exact path={RoutePaths.BookListing} component={BookList} />
			<PrivateRoute exact path={RoutePaths.Book} component={Book} />
			<PrivateRoute exact path={RoutePaths.AddBook} component={EditBook} />
			<PrivateRoute exact path={RoutePaths.EditBook} component={EditBook} />
			<PrivateRoute exact path={RoutePaths.Cart} component={Cart} />
		</Switch>
	);
};

export default AppRoutes;
