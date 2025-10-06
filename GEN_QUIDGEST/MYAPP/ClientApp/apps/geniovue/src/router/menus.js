// eslint-disable-next-line @typescript-eslint/no-unused-vars
import { updateQueryParams } from './routeUtils.js'

export default function getMenusRoutes()
{
	return [
		{
			path: '/:culture/:system/RMS/menu/RMS_21',
			name: 'menu-RMS_21',
			component: () => import('@/views/menus/ModuleRMS/MenuRMS_21/QMenuRms21.vue'),
			meta: {
				routeType: 'menu',
				module: 'RMS',
				order: '21',
				baseArea: 'U_PRF',
				hasInitialPHE: false,
				humanKeyFields: ['ValUsername'],
			}
		},
	]
}
