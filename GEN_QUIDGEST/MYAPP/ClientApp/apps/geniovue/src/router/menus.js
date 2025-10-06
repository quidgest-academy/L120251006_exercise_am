// eslint-disable-next-line @typescript-eslint/no-unused-vars
import { updateQueryParams } from './routeUtils.js'

export default function getMenusRoutes()
{
	return [
		{
			path: '/:culture/:system/RMS/menu/RMS_11',
			name: 'menu-RMS_11',
			component: () => import('@/views/menus/ModuleRMS/MenuRMS_11/QMenuRms11.vue'),
			meta: {
				routeType: 'menu',
				module: 'RMS',
				order: '11',
				baseArea: 'T_001',
				hasInitialPHE: false,
				humanKeyFields: ['ValEmail'],
			}
		},
	]
}
